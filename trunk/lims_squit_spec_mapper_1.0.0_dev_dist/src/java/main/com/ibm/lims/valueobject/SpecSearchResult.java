package com.ibm.lims.valueobject;

import java.util.List;


/**
 * <p>
 * This class represents the spec list search result.
 * It contains the matched results on specific page and the total number of matched results.
 * </p>
 * <p>
 * Thread-safety: The TestDetailsVO class is mutable, so it's not thread-safe.
 * </p>
 * 
 * @author phead
 * @version 1.0
*/
public class SpecSearchResult {
    /**
     * <p>
     * Represents a list of matched TestDetailsVO objects on specific page.
     * Initialized in constructor and never changed afterwards.
     * Must be non-null. can be empty. Must contain non-null element.
     * Has getter.
     * </p>
    */
    private final List<TestDetailsVO> specList;

    /**
     * <p>
     * Represents the total number of matched results.
     * Initialized in ctor, and never changed afterwards.
     * Must be >= 0.  Has getter.
     * </p>
    */
    private final int totalCount;

    /**
     * <p>
     * Constructor with matched specs on specific page and total number of matched specs.
     * Shallowly copy the specList argument to the namesake instance variable.
     * Assign the totalCount argument to the namesake instance variable.
     * </p>
     * @throws IllegalArgumentException
     *            if the specList is null or contains null element.
     *            or totalCount is negative.
     * @param specList
     *            the matched specs on specific page.
     * @param totalCount
     *            the total number of matched specs.
    */
    public SpecSearchResult(List<TestDetailsVO> specList, int totalCount) {
    	if(specList == null || specList.isEmpty())
    		throw new IllegalArgumentException("Parameter specMapList is null or empty.");
    	if(totalCount < 0)
    		throw new IllegalArgumentException("Parameter totalCount is less than 0.");
    	this.specList = specList;
    	this.totalCount = totalCount;
    }

    /**
     * <p>
     * Getter for the namesake instance variable.
     * </p>
     * @return the matched specs on specific page.
    */
    public List<TestDetailsVO> getSpecList() {
        return specList;
    }

    /**
     * <p>
     * Getter for the namesake instance variable.
     * </p>
     * @return the total number of matched specs.
    */
    public int getTotalCount() {
        return totalCount;
    }
}
