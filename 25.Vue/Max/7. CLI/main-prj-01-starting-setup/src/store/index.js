import { createStore } from 'vuex';
import coachesModules from './modules/coaches/_index.js';
import requestsModules from './modules/requests/_index.js';
import authModules from './modules/auth/_index.js';

const store = createStore({
    modules: {
        coaches: coachesModules,
        requests: requestsModules,
        auth: authModules
    },

});

export default store