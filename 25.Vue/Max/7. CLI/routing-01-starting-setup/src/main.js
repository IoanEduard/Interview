import { createApp } from 'vue';
import { createRouter, createWebHistory } from 'vue-router';

import App from './App.vue';
import TeamsList from './components/teams/TeamsList.vue';
import TeamMembers from './components/teams/TeamMembers.vue';
import UsersList from './components/users/UsersList.vue';
import TeamsFooter from './components/teams/TeamsFooter.vue';
import UsersFooter from './components/users/UsersFooter.vue';

const router = createRouter({
    history: createWebHistory(),
    routes: [
        { path: '/', redirect: 'teams-list' },
        {
            name: 'teams',
            path: '/teams-list',
            meta: { needsAuth: true },
            components: { default: TeamsList, footer: TeamsFooter },
            children: [
                { name: 'team-members', path: ':teamId', component: TeamMembers, props: true },
            ]
        },
        {
            path: '/users-list',
            component: UsersList,
            components: {
                default: UsersList,
                footer: UsersFooter
            },
            beforeEnter(to, from, next) {
                console.log(to, from);
                next();
            }
        },
        { path: '/:notFound(.*)', redirect: '/teams' }, // or a notfound component

    ],
    linkActiveClass: 'active',
    scrollBehavior(to, from, savedPosition) {
        console.log(to);
        console.log(from);
        console.log(savedPosition);
        if (savedPosition) {
            return savedPosition;
        }
        return {
            left: 0,
            top: 0,
        };
    }
});

router.beforeEach(function(to, from, next) {
    console.log(to, from);
    if (to.meta.needsAuth) {
        console.log('needs auth');
        next();
    }
    next('/users-list');
    if (to.name === 'team-members') {
        next();
    } else {
        next({ name: 'team-members', params: { teamId: 't2' } });
    }
});

router.afterEach(function(to, from) {
    // sending analystics data
    console.log(to, from);
});

const app = createApp(App)

app.use(router);
app.mount('#app');