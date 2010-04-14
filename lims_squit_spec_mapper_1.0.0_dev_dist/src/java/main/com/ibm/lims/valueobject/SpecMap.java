package com.ibm.lims.valueobject;


/**
 * <p>
 * This class represents the spec mapping between LIMS and SQUIT.
 * It contains a unique id; LIMS spec name, code, unit and element;
 * SQUIT spec name, code, unit and element; operation and operand.
 * </p>
 * <p>
 * Thread-safety: Mutable and not thread-safe.
 * </p>
 * 
 * @author phead
 * @version 1.0
*/
public class SpecMap {
    /**
     * <p>
     * Represents the spec map id.
     * It can be any value.
     * It has getter and setter.
     * </p>
    */
    private long specMapId;

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
     * Represents the SQUIT spec code.
     * It can be any value.
     * It has getter and setter.
     * </p>
    */
    private String squitSpecCode;

    /**
     * </p>
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
     * Represents the SQUIT unit.
     * It can be any value.
     * It has getter and setter.
     * </p>
    */
    private String squitUnit;

    /**
     * <p>
     * Represents the new unit.
     * It can be any value.
     * It has getter and setter.
     * </p>
    */
    private String newUnit;

    /**
     * <p>
     * Represents the operation to be performed.  Default to NONE.
     * It must be values defined in Operation enum class.
     * It has getter and setter.
     * </p>
    */
    private Operation operation = Operation.NONE;

    /**
     * <p>
     * Represents the operand.
     * It can be any value.
     * It has getter and setter.
     * </p>
    */
    private Double operand;

    /**
     * <p>
     * Empty constructor.
     * </p>
    */
    public SpecMap() {
    }

    /**
     * <p>
     * Getter for the namesake instance variable.
     * </p>
     * @return the spec map id.
    */
    public long getSpecMapId() {
        return specMapId;
    }

    /**
     * <p>
     * Setter for the namesake instance variable.
     * </p>
     * @param specMapId
     *            the spec map id.
    */
    public void setSpecMapId(long specMapId) {
    	this.specMapId = specMapId;
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
     * @return the new unit
    */
    public String getNewUnit() {
        return newUnit;
    }

    /**
     * <p>
     * Setter for the namesake instance variable.
     * </p>
     * Simply assign the value to the namesake instance variable.
     * @param newUnit
     *            the new unit.
    */
    public void setNewUnit(String newUnit) {
    	this.newUnit = newUnit;
    }

    /**
     * <p>
     * Getter for the namesake instance variable.
     * </p>
     * @return the operand
    */
    public Double getOperand() {
        return operand;
    }

    /**
     * <p>
     * Setter for the namesake instance variable.
     * </p>
     * @param operand
     *            the operand.
    */
    public void setOperand(Double operand) {
    	this.operand = operand;
    }

    /**
     * <p>
     * Getter for the namesake instance variable.
     * </p>
     * @return the  LIMS spec code
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
     * @return the operation.
    */
    public Operation getOperation() {
        return operation;
    }

    /**
     * <p>
     * Setter for the namesake instance variable.
     * </p>
     * @throws IllegalArgumentException 
     *            if the argument is not defined in Operation enum class.
     * @param operation
     *            the operation.
    */
    public void setOperation(Operation operation) throws IllegalArgumentException {
    	if(!(operation.equals(Operation.DIVIDE) || operation.equals(Operation.MULTIPLY) ||
    			operation.equals(Operation.NONE)))
    			throw new IllegalArgumentException("Operation is not defined in Operation_Enum");
    	this.operation = operation;
    }

    /**
     * <p>
     * Getter for the namesake instance variable.
     * </p>
     * @return the SQUIT unit
    */
    public String getSquitUnit() {
        return squitUnit;
    }

    /**
     * <p>
     * Setter for the namesake instance variable.
     * </p>
     * @param squitUnit
     *            the SQUIT unit.
    */
    public void setSquitUnit(String squitUnit) {
    	this.squitUnit = squitUnit;
    }
}
