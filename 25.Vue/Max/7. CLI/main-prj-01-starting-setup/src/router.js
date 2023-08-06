import { createRouter, createWebHistory } from 'vue-router';

import CoachesDetails from './pages/coaches/CoachesDetails.vue';
import CoachList from './pages/coaches/CoachesList.vue';
import CoachRegistration from './pages/coaches/CoachesRegister.vue';
import ContactCoach from './pages/requests/ContactCoach.vue';
import RequestsReceived from './pages/requests/RequestsReceived.vue';
import Auth from './pages/auth/UserAuth.vue';


import NotFound from './pages/NotFound.vue';
import store from './store/modules/auth/_index';

const router = createRouter({
    history: createWebHistory(),
    routes: [
        { path: '/', redirect: '/coaches' },
        {
            path: '/coaches',
            component: CoachList
        },
        {
            path: '/coaches/:id',
            component: CoachesDetails,
            props: true,
            children: [
                { path: 'contact', component: ContactCoach }
            ]
        },
        {
            path: '/register',
            component: CoachRegistration,
            meta: {
                requiresAuth: true
            }
        },
        {
            path: '/requests',
            component: RequestsReceived,
            meta: {
                requiresAuth: true
            }
        },
        {
            path: '/auth',
            component: Auth,
            meta: {
                requiresAnonymous: true
            }
        },
        { path: '/:notFound(.*)', component: NotFound },
    ]
});

router.beforeEach((to, _, next) => {
    if (to.meta.requiresAuth && !store.getters.isAuthenticated)
        next('/auth');
    else if (to.meta.requiresAnonymous && store.getters.isAuthenticated)
        next('/coaches');
    else next();
})

export default router;