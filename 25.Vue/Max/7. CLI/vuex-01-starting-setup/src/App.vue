<template>
  <div>
    <base-container title="Vuex" v-if="isAuth">
      <!-- <h3>{{ $store.state.counter }}</h3> -->
      <the-counter></the-counter>
      <button @click="addOne">Add 10</button>
      <change-counter></change-counter>
      <favorite-value></favorite-value>
    </base-container>
    <base-container title="Auth">
      <user-auth></user-auth>
    </base-container>
  </div>
</template>

<script>
import TheCounter from './components/TheCounter.vue';
import BaseContainer from './components/BaseContainer.vue';
import ChangeCounter from './components/ChangeCounter.vue';
import FavoriteValue from './components/FavoriteValue.vue';
import UserAuth from './components/UserAuth.vue';

export default {
  components: {
    BaseContainer,
    TheCounter,
    ChangeCounter,
    FavoriteValue,
    UserAuth,
  },

  methods: {
    addOne() {
      // this.$store.commit('increase', { value: 10 });
      // this.$store.commit({
      this.$store.dispatch({
        type: 'increase',
        value: 10,
      });
    },
    computed: {
      isAuth() {
        return this.$store.getters.userIsAuthenticated;
      },
    },
  },
};
</script>

<style>
* {
  box-sizing: border-box;
}

html {
  font-family: sans-serif;
}

body {
  margin: 0;
}
</style>