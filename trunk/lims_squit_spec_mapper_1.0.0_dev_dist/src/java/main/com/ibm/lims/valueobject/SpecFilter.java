package com.ibm.lims.valueobject;


/**
 * <p>
 * This class represents the filter used to search the LIMS and SQUIT spec.
 * It contains spec code, name, and element values. All of them are optional.
 * </p>
 * <p>
 * Thread-safety: Mutable and not thread-safe.
 * </p>
 *
 * @author phead
 * @version 1.0
*/
public class SpecFilter {
    /**
     * <p>
     * Represents the spec code.
     * It can be any value.
     * It has getter and setter.
     * </p>
    */
    private String specCode;

    /**
     * <p>
     * Represents the spec name.
     * It can be any value.
     * It has getter and setter.
     * </p>
    */
    private String specName;

    /**
     * <p>
     * Represents the spec element.
     * It can be any value.
     * It has getter and setter.
     * </p>
    */
    private String element;

    /**
     * <p>
     * Empty constructor.
     * </p>
    */
    public SpecFilter() {
    }

    /**
     * <p>
     * Getter for the namesake instance variable.
     * </p>
     * @return the spec code.
    */
    public String getSpecCode() {
        return specCode;
    }

    /**
     * <p>
     * Setter for the namesake instance variable.
     * </p>
     * @param specCode
     *            the spec code.
    */
    public void setSpecCode(String specCode) {
    	this.specCode = specCode;
    }

    /**
     * <p>
     * Getter for the namesake instance variable.
     * </p>
     * @return the spec name.
    */
    public String getSpecName() {
        return specName;
    }

    /**
     * <p>
     * Setter for the namesake instance variable.
     * </p>
     * @param specName
     *             the spec name.
    */
    public void setSpecName(String specName) {
    	this.specName = specName;
    }

    /**
     * <p>
     * Getter for the namesake instance variable.
     * </p>
     * @return the spec element.
    */
    public String getElement() {
        return element;
    }

    /**
     * <p>
     * Setter for the namesake instance variable.
     * </p> 
     * @param element
     *            the spec element.
    */
    public void setElement(String element) {
    	this.element = element;
    }
}
