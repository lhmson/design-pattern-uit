import NormalLogger from './normalLogger.js'

const logger = new NormalLogger()

export default function logFirstImplementation() {
    logger.printLogCount()
    logger.log('First file')
    logger.printLogCount()
}