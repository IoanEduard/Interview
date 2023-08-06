const app = Vue.createApp({
    data() {
        return {
            inputValue: ''
        }
    },
    methods: {
        showAlert() {
            alert('alert');
        },
        getInPutValue(event) {
            // console.log(event);
            this.inputValue = event.target.value;
        }
    }
})

app.mount('#assignment');