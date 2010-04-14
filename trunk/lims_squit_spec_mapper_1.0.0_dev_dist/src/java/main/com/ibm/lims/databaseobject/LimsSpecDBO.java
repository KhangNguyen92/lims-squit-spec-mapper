package com.ibm.lims.databaseobject;

import com.ibm.lims.valueobject.SpecFilter;
import com.ibm.lims.valueobject.SpecMap;
import com.ibm.lims.valueobject.SpecMapFilter;
import com.ibm.lims.valueobject.SpecMapSearchResult;
import com.ibm.lims.valueobject.SpecSearchResult;


/**
 *
*/
public class LimsSpecDBO {
    /**
     * Constructor.
    */
    public LimsSpecDBO() {
    }

    /**
     * Get LIMS specs filtered by the given SpecFilter.
     * All fields in SpecFilter are optional.
     *
     * #Param
     * specFilter - the spec filter.
     * pageSize - the page size.
     * pageNo - the current page no. starting from 0.
     *
     * #Return - the matched LIMS specs.
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

    /**
     * Insert spec map.
     *
     * #Param
     * map - the spec map to insert.
     *
     * #Return - the unique id of the inserted spec map.
     * @param Return
     * @param map
     * @return
    */
    public long insertSpecMap(SpecMap map) {
        return 0;
    }

    /**
     * Get spec map by id.
     *
     * #Param
     * specMapId - the spec map id.
     *
     * #Return - the corresponding spec map.
     * @param Return
     * @param specMapId
     * @return
    */
    public SpecMap getSpecMap(long specMapId) {
        return null;
    }

    /**
     * Update spec map.
     *
     * #Param
     * specMap - the spec map to update.
     * @param specMap
     * @param Return
    */
    public void updateSpecMap(SpecMap specMap) {
    }

    /**
     * Delete spec maps.
     *
     * #Param
     * specMapIds - an array of spec map ids.
     * @param Return
     * @param specMapIds
    */
    public void deleteSpecMaps(long[] specMapIds) {
    }

    /**
     * Get spec maps by the filter.
     *
     * #Param
     * specMapFilter - the spec map filter.
     * pageSize - the page size.
     * pageNo - the current page no. starting from 0.
     *
     * #Return - the matched spec maps.
     * @param specMapFilter
     * @param pageNo
     * @param Return
     * @param pageSize
     * @return
    */
    public SpecMapSearchResult getSpecMapList(SpecMapFilter specMapFilter,
        int pageSize, int pageNo) {
        return null;
    }

    /**
     * Check the SpecMap already exists or not.
     *
     * #Param
     * specMap - the spec map to verify
     *
     * #Return - true if the spec map already exists, false otherwise.
     * @param specMap
     * @param Return
     * @return
    */
    public boolean existsSpecMap(SpecMap specMap) {
        return false;
    }
}
