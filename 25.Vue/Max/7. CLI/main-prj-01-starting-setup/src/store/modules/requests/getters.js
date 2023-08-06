export default {
    requests(state, _, _1, rootGetters) {
        const userId = rootGetters.userId;
        return state.requests.filter(c => c.coachId === userId);
    },
    hasRequests(_, getters) {
        return getters.requests && getters.requests.length > 0;

    }
}