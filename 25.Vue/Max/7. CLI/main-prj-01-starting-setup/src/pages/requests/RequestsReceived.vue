<template>
  <section>
    <base-dialog :show="!!error" title="error occured" @close="handleError"
      ><p>{{ error }}</p></base-dialog
    >
    <base-card>
      <header>
        <h2>requests received</h2>
      </header>
      <base-spinner v-if="isLoading"></base-spinner>
      <ul v-else-if="hasRquests && !isLoading">
        <request-item
          v-for="req in receivedRequests"
          :key="req.id"
          :email="req.userEmail"
          :message="req.message"
        >
        </request-item>
      </ul>
      <h3 v-else>no requests</h3>
    </base-card>
  </section>
</template>

<script>
import requestItem from '../../components/requests/RequestItem.vue';
export default {
  components: {
    requestItem,
  },
  data() {
    return {
      isLoading: false,
      error: null,
    };
  },
  computed: {
    receivedRequests() {
      console.log(this.$store.getters['requests/requests']);
      return this.$store.getters['requests/requests'];
    },
    hasRquests() {
      return this.$store.getters['requests/hasRequests'];
    },
  },
  created() {
    this.loadRequests();
  },
  methods: {
    async loadRequests() {
      this.isLoading = true;
      try {
        await this.$store.dispatch('requests/fetchRequests');
      } catch (error) {
        this.error = error.message || 'fail';
      }
      this.isLoading = false;
    },
    handleError() {
      this.error = null;
    },
  },
};
</script>


<style scoped>
header {
  text-align: center;
}

ul {
  list-style: none;
  margin: 2rem auto;
  padding: 0;
  max-width: 30rem;
}

h3 {
  text-align: center;
}
</style>