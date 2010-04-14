package com.ibm.lims.valueobject;


/**
 * <p>
 * This class represents the filter used to search the SpecMap.
 * It contains spec code, name, and element values for SQUIT and LIMS respectively.
 * All of them are optional.
 * </p>
 * <p>
 * Thread-safety: Mutable and not thread-safe.
 * </p>
 * 
 * @author phead
 * @version 1.0
*/
public class SpecMapFilter {
    /**
     * <p>
     * Represents the SQUIT spec code.
     * It can be any value.
     * It has getter and setter.
     * </p>
    */
    private String squitSpecCode;

    /**
     * <p>
     * Represents the SQUIT spec name.
     * It can be any value.
     * It has getter and setter.
     * </p>
    */
    private String squitSpecName;

    /**
     * <p>
     * Represents the SQUIT spec element.
     * It can be any value.
     * It has getter and setter.
     * </p>
    */
    private String squitElement;

    /**
     * <p>
     * Represents the LIMS spec code.
     * It can be any value.
     * It has getter and setter.
     * </p>
    */
    private String limsSpecCode;

    /**
     * <p>
     * Represents the LIMS spec name.
     * It can be any value.
     * It has getter and setter.
     * </p>
    */
    private String limsSpecName;

    /**
     * <p>
     * Represents the LIMS spec element.
     * It can be any value.
     * It has getter and setter.
     * </p>
    */
    private String limsElement;

    /**
     * <p>
     * Empty constructor.
     * </p>
    */
    public SpecMapFilter() {
    }

    /**
     * <p>
     * Getter for the namesake instance variable.
     * </p>
     * @return the SQUIT spec code.
    */
    public String getSquitSpecCode() {
        return squitSpecCode;
    }

    /**
     * <p>
     * Setter for the namesake instance variable.
     * </p>
     * @param squitSpecCode
     *            the squit spec code.
    */
    public void setSquitSpecCode(String squitSpecCode) {
    	this.squitSpecCode = squitSpecCode;
    }

    /**
     * <p>
     * Getter for the namesake instance variable.
     * </p>
     * @return the SQUIT spec name.
    */
    public String getSquitSpecName() {
        return squitSpecName;
    }

    /**
     * <p>
     * Setter for the namesake instance variable.
     * </p>
     * @param squitSpecName
     *            the SQUIT spec name.
    */
    public void setSquitSpecName(String squitSpecName) {
    	this.squitSpecName = squitSpecName;
    }

    /**
     * <p>
     * Getter for the namesake instance variable.
     * </p>
     * @return the SQUIT element.
    */
    public String getSquitElement() {
        return squitElement;
    }

    /**
     * <p>
     * Setter for the namesake instance variable.
     * </p>
     * @param squitElement
     *            the SQUIT element.
    */
    public void setSquitElement(String squitElement) {
    	this.squitElement = squitElement;
    }

    /**
     * <p>
     * Getter for the namesake instance variable.
     * </p>
     * @return the LIMS spec code
    */
    public String getLimsSpecCode() {
        return limsSpecCode;
    }

    /**
     * <p>
     * Setter for the namesake instance variable.
     * </p>
     * @param limsSpecCode
     *            LIMS spec code.
    */
    public void setLimsSpecCode(String limsSpecCode) {
    	this.limsSpecCode = limsSpecCode;
    }

    /**
     * <p>
     * Getter for the namesake instance variable.
     * </p>
     * @return the LIMS spec name.
    */
    public String getLimsSpecName() {
        return limsSpecName;
    }

    /**
     * <p>
     * Setter for the namesake instance variable.
     * </p>
     * @param limsSpecName
     *            the LIMS spec name.
    */
    public void setLimsSpecName(String limsSpecName) {
    	this.limsSpecName = limsSpecName;
    }

    /**
     * <p>
     * Getter for the namesake instance variable.
     * </p>
     * @return the LIMS element.
    */
    public String getLimsElement() {
        return limsElement;
    }

    /**
     * <p>
     * Setter for the namesake instance variable.
     * </p>
     * @param limsElement
     *            the LIMS element.
    */
    public void setLimsElement(String limsElement) {
    	this.limsElement = limsElement;
    }
}
