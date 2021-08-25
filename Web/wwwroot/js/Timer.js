class Timer {
    constructor(elementID) {
        this.elementID = elementID;
        this.timeInterval;
        this.contador = 0;
    }

    Format() {
        const seconds = Math.floor((this.contador) % 60);
        const minutes = Math.floor((this.contador / 60) % 60);
        return ('0' + minutes).slice(-2) + ':' + ('0' + seconds).slice(-2);
    }

    Play() {
        this.timeInterval = setInterval(() => {
            this.contador++;
            document.getElementById(this.elementID).innerHTML = this.Format();
        }, 1000);
    }

    Pause() {
        clearInterval(this.timeInterval);
    }
}