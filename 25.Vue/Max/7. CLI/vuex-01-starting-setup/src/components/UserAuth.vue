<template>
  <div>
    <button @click="login" v-if="!userIsAuthenticated">Login</button>
    <button @click="logout" v-if="userIsAuthenticated">Logout</button>
  </div>
</template>

<script>
export default {
    methods: {
        login() {
            this.$store.dispatch('login')
        },
        logout() {
            this.$store.dispatch('logout')
        }
    },
    computed: {
        isAuth() {
            return this.$store.getters.userIsAuthenticated;
        }
    }
}
</script>