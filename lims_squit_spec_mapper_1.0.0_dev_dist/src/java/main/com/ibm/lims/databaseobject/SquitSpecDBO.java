package com.ibm.lims.databaseobject;

import com.ibm.lims.valueobject.*;


/**
*/
public class SquitSpecDBO {
    /**
     * Constructor.
    */
    public SquitSpecDBO() {
    }

    /**
     * Get SQUIT specs filtered by the given SpecFilter.
     * All fields in SpecFilter are optional.
     *
     * #Param
     * specFilter - the spec filter.
     * pageSize - the page size.
     * pageNo - the current page no.  starting from 0.
     *
     * #Return - the matched SQUIT specs.
     * @param specFilter
     * @param pageNo
     * @param Return
     * @param pageSize
     * @return
    */
    public SpecSearchResult getSpecList(SpecFilter specFilter, int pageSize,
        int pageNo) {
        return null;
    }
}
