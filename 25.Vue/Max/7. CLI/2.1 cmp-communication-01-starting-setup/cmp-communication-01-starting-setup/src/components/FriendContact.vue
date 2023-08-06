

<template>
  <li>
    <h2>{{ f.name }} {{f.isFavorite ? '(Favorite)': ''}}</h2>
    <button @click="toggleDetails">
      {{ detailsAreVisible ? "Hide" : "Show" }} Details
    </button>
    <button @click="toggleIsFavorite"> Favorite
    </button>
    <ul v-if="detailsAreVisible">
      <li>
        <strong>Phone:</strong>
        {{ f.phone }}
      </li>
      <li>
        <strong>Email:</strong>
        {{ f.email }}
      </li>
    </ul>
  </li>
</template>

<script>

export default {
  props: ['friend'],
  // emits: ['toggle-favorite'],
  emits: {
    'toggle-favorite': function(id) {
      if(id){
        return true
      }
      else{
        console.warn('id is missing');
        return false;
      }
    }
  },
  data() {
    return {
      detailsAreVisible: false,
      f: this.friend
    };
  },
  methods: {
    toggleDetails() {
      this.detailsAreVisible = !this.detailsAreVisible;
    },
    toggleIsFavorite() {
      this.$emit('toggle-favorite', this.f.id);
    },
  },
};
</script>