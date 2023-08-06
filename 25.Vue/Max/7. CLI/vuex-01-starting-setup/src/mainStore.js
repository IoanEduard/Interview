import { createStore } from 'vuex';

import authStore from './authStore.js';
import counterStore from './authStore.js';

const store = createStore({
    modules: {
        authStore: authStore,
        counterStore: counterStore
    }
});

export default store;