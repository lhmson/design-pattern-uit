import logger from './singletonLogger.js'

export default function logSecondImplementation() {
    logger.printLogCount()
    logger.log('Second file')
    logger.printLogCount()
}