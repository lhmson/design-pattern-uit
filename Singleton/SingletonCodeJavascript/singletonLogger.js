export class SingletonLogger {
    constructor() {
        if (SingletonLogger.instance == null) {
            this.logs = [];
            SingletonLogger.instance = this;
        }
        return SingletonLogger.instance;
    }

    log(message) {
        this.logs.push(message)
        console.log(`SINGLETON LOG: ${message}`)
    }

    printLogCount() {
        console.log(`${this.logs.length} Logs`)
    }
}

const logger = new SingletonLogger();
Object.freeze(logger);
export default logger;