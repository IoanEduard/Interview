import { createStore } from 'vuex';

const counterStore = createStore({
    state() {
        return {
            counter: 0
        }
    },
    mutations: {
        increment(state) {
            // bad practice, vuex has actions
            // setTimeout(() => {
            state.counter++;
            // }, 2000);
        },
        increase(state, payload) {
            state.counter = state.counter + payload.value;
        },
    },
    actions: {
        increment(context, payload) {
            setTimeout(() => {
                context.commit('increment', payload);
            }, 2000);
        },
        increase(context, payload) {
            context.commit('increase', payload);
        },
    },
    getters: {
        finalCounter(state) {
            return state.counter * 2;
        },
        normalizedCounter(_, getters) {
            const finalCounter = getters.finalCounter;
            if (finalCounter < 0) {
                return 0;
            }
            if (finalCounter > 100) { return 100; }
            return finalCounter;
        },
    }
});

export default counterStore;