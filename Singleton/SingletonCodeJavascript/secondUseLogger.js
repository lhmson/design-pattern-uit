import NormalLogger from './normalLogger.js'

const logger = new NormalLogger()

export default function logSecondImplementation() {
    logger.printLogCount()
    logger.log('Second file')
    logger.printLogCount()
}