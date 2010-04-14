package com.ibm.lims.actions.transformer;


/**
 * <p>
 * This exception extends the Exception class and it's thrown from the SpecMappingAction class
 * if any error occurs when processing the request.
 * </p>
*/
public class SpecMappingActionException extends Exception {
    /**
     * <p>
     * Constructor with error message.
     * </p>
     * @param message
     *            the error message.
    */
    public SpecMappingActionException(String message) {
    	super(message);
    }

    /**
     * <p>
     * Constructor with error message and inner cause
     * </p>
     * @param message
     *            the error message.
     * @param cause
     *            the inner cause
    */
    public SpecMappingActionException(String message, Throwable cause) {
    	super(message, cause);
    }
}
