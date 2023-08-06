<template>
  <section>
    <h2>Register as a coach</h2>
    <coach-form @save-data="saveData"></coach-form>?
  </section>
</template>

<script>
import CoachForm from '../../components/coaches/CoachForm.vue';
export default {
  components: {
    coachForm: CoachForm,
  },
  methods: {
    saveData(eventData) {
        this.$store.dispatch('coaches/registerCoach', eventData);
        this.$router.replace('/coaches');
    },
  },
};
</script>

<style>
</style>