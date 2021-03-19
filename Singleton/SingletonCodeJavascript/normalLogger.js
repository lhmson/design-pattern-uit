export default class NormalLogger {
    constructor() {
        this.logs = []
    }

    log(message) {
        this.logs.push(message)
        console.log(`NORMAL LOG: ${message}`)
    }

    printLogCount() {
        console.log(`${this.logs.length} Logs`)
    }
}