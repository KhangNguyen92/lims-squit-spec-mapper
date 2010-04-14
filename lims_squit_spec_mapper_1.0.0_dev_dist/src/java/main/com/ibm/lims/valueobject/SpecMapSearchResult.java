package com.ibm.lims.valueobject;

import java.util.List;


/**
 * <p>
 * This class represents the spec map list search result.
 * It contains the matched results on specific page and the total number of matched results.
 * </p>
 * <p>
 * Thread-safety: The SpecMap class is mutable, so it's not thread-safe.
 * </p>
 * 
 * @author phead
 * @version 1.0
*/
public class SpecMapSearchResult {
    /**
     * <p>
     * Represents a list of matched SpecMap objects on specific page.
     * Initialized in constructor and never changed afterwards.
     * Must be non-null. can be empty. Must contain non-null element.
     * Has getter.
     * </p>
    */
    private final List<SpecMap> specMapList;

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
     * Constructor with matched spec maps on specific page and total number of matched spec maps.
     * Shallowly copy the specMapList argument to the namesake instance variable.
     * Assign the totalCount argument to the namesake instance variable.
     * </p>
     * @throws IllegalArgumentException
     *            if the specMapList is null or contains null element.
     *            or totalCount is negative.
     * @param specMapList
     *            the matched spec maps on specific page.
     * @param totalCount
     *            the total number of matched specs.
    */
    public SpecMapSearchResult(List<SpecMap> specMapList, int totalCount) throws IllegalArgumentException{
    	if(specMapList == null || specMapList.isEmpty())
    		throw new IllegalArgumentException("Parameter specMapList is null or empty.");
    	if(totalCount < 0)
    		throw new IllegalArgumentException("Parameter totalCount is less than 0.");
    	this.specMapList = specMapList;
    	this.totalCount = totalCount;
    }

    /**
     * <p>
     * Getter for the namesake instance variable.
     * </p>
    */
    public List<SpecMap> getSpecMapList() {
        return specMapList;
    }

    /**
     * <p>
     * Getter for the namesake instance variable.
     * </p>
     * @return the total number of matched spec maps.
    */
    public int getTotalCount() {
        return totalCount;
    }
}
