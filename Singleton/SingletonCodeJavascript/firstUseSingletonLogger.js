import logger from './singletonLogger.js'

export default function logFirstImplementation() {
    logger.printLogCount()
    logger.log('First file')
    logger.printLogCount()
}