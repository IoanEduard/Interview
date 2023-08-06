const vueApp = Vue.createApp({
    data() {
        return {
            name: 'eduard',
            age: 25,
            flower: 'https://static.pexels.com/photos/36753/flower-purple-lical-blosso.jpg'
        }
    },
    methods: {
        ageInFive() {
            return this.age + 5;
        },
        favoriteNumber() {
            return Math.random();
        }
    }
});

vueApp.mount('#assignment');