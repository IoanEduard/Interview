const app = Vue.createApp({
    data() {
        return {
            courseGoal: 'some goal',
            courseGoal2: '<h2>some goal 2</h2>',
            vueLink: 'https://some.com'
        };
    },
    methods: {
        outputGoal() {
            const randomNumber = Math.random();
            if (randomNumber < 0.5)
                return this.courseGoal;
            else
                return this.courseGoal2;
        }
    }
});

app.mount('#user-goal');