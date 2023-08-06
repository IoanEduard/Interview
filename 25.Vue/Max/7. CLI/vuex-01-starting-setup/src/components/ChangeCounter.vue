<template>
  <div>
    <button @click="addOne">Add 1</button>
    <button @click="increment({value: 11})">Add 11</button>
  </div>
</template>

<script>
import { mapActions } from 'vuex';
export default {
  methods: {
    // addOne() {
    //   this.$store.commit('increment');
    // },
    // ...mapActions(['increment', 'increase']),
    ...mapActions({
        inc: 'increment',
        increase: 'increase'
    }),
  },
};
</script>