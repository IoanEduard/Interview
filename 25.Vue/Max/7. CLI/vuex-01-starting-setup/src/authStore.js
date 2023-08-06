import { createStore } from 'vuex';


// states are local rootstate and rootGetters are the save
const authStore = createStore({
    state() {
        return {
            isLoggedIn: false
        }
    },
    mutations: {

        setAuth(state, payload) {
            console.log(payload);
            state.isLoggedIn = payload.isAuth;
        }
    },
    actions: {

        login(context) {
            context.commit('setAuth', { isAuth: true });
        },
        logout(context) {
            context.commit('setAuth', { isAuth: false });
        }
    },
    getters: {
        userIsAuthenticated(state) {
            return state.isLoggedIn;
        }
    },
});

export default authStore;