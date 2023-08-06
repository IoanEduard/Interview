const app = Vue.createApp({
    data() {
        return {
            counter: 10,
            name: '',
            confirmedName: '',
            fullName: '',
            lastname: ''
        };
    },
    // updating some data dynamically 
    computed: {
        // methods here will be called and executed differently
        // we do not call this in the view with () but we point to the method
        // fullname not fullname(), Vue will call it and we use them as properties not like functions
        fullName() { // data property
            return this.name === '' ? '' : this.name + this.lastname;
            // return this.name === '' ? '' : this.name + 'Eduard';
        }
    },
    // watch is great when lets say counter exceeds 50 and we wanna reset it
    // timers, http requests
    // run some code also updates some data property in reaction of a property changing
    watch: {
        counter(value) {
            if (value > 50) this.counter = 0;
        }
        // name(value) {
        //     this.fullName = this.name === '' ? '' : value + ' ' + lastname;
        // },
        // lastName(value) {
        //     this.fullName = this.name === '' ? '' : this.name + ' ' + value;
        // }
    },
    methods: {
        setName(event) {
            this.name = event.target.value;
        },
        add(event) {
            this.counter += 5;
        },
        reduce() {
            this.counter--;
        },
        submitForm(event) {
            // event.preventDefault();
            console.log('submitted');
        },
        confirmInput() {
            this.confirmedName = this.name;
        },
        resetInput() {
            this.name = '';
        }
    },

});

app.mount('#events');

/**
 * *** Methods
 * with event binding of data binding
 * data binding: method is executed for every "re-render" cycle of the component
 * use for events or data that really needs to be re-evaluated all the time
 * 
 * *** Computed
 * Use with data binding
 * computed properties are only re-evaluated if one of their used values changed
 * use for data that depends on other data
 * 
 * *** Watch
 * not used directly in template
 * allows you to run some code in reaction to changed data e.g: http requests
 * use for any non-data update you want to make
 */