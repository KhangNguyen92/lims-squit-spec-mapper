package com.ibm.lims.actions.transformer;

import com.ibm.lims.databaseobject.*;
import com.ibm.lims.valueobject.SpecFilter;

import org.apache.log4j.*;

import org.apache.struts.action.*;
import org.apache.struts.actions.DispatchAction;

import javax.servlet.http.*;


/**
 * This class extends the DispatchAction and it provides methods to search the LIMS specs, search the SQUIT specs, search Spec Mappings, edit spec mapping, update (add or edit) spec mapping and delete spec mappings.
 *
 * It will uses the DBO classes to interact with the persistence, and it will also use Log4J to log exceptions.
 *
 * Thread-safety: Immutable and thread-safe.
*/
public class SpecMappingAction extends DispatchAction {
    /**
     * Represents the SquitSpecDBO object.
     * Created in constructor, and never changed afterwards. it has getter.
     * Must be non-null.  Used in searchSquitSpecs to search specs.
    */
    private final SquitSpecDBO squitSpecDBO;

    /**
     * Represents the LimsSpecDBO object.
     * Created in constructor, and never changed afterwards. it has getter.
     * Must be non-null. Used in nearly all methods (except the searchSquitSpecs) to manage the LIMS spec and spec mappings.
    */
    private final LimsSpecDBO limsSpecDBO;

    /**
     * Represents the Logger object.
     * Created in constructor, and never changed afterwards.
     * Must be non-null.  Used in all methods to log invocation details.
    */
    private final Logger logger;

    /**
     * <p>
     * Constructor to intialize the action.
     * </p>
    */
    public SpecMappingAction() {
    	squitSpecDBO = new SquitSpecDBO();
        limsSpecDBO = new LimsSpecDBO();
        logger = Logger.getLogger(this.getClass().getName());
    }

    /**
     * Search the LIMS specs.  Paging is supported, and 20 records will be shown on each page.
     * The LIMS spec can be filtered by spec code, name, and element.
     *
     * #Param
     * mapping - the action mapping.
     * form - the action form.
     * request - the http servlet request.
     * response - the http servlet response.
     *
     * #Return - the action forward.
     *
     * #Exception
     * throw IllegalArgumentException if any argument is null.
     * throw SpecMappingActionException if any error occurs in DBO operation.
     *
     * #Impl
     * Extract the following request parameters: "specCode" - the spec code, optional, can be any value."specName" - the spec name, optional, can be any value."element" - the spec element, optional, can be any value."pageNo" - the current page number, starting from 0. optional. Use 0 instead if it's missing or it's not integer value or it's negative integer.
     *
     * Create filter = new SpecFilter();
     * Assign extracted specCode, specName, element parameter values to namesake fields in filter.
     * Note that the extracted specCode, specName, and element can be null or empty string.
     *
     * Call result = limsSpecDBO.getSpecList(filter, 20, the-pageNo-value) to get matched LIMS specs.
     * Call request.setAttribute("specs", result.getSpecList());
     * Call request.setAttribute("totalCount", new Integer(result.getTotalCount()));
     * Call request.setAttribute("pageNo", the-pageNo-value);
     *
     * Return mapping.findForward("searchLimsSpecs");
     * @param response
     * @param form
     * @param request
     * @param Return
     * @param mapping
     * @return
    */
    public ActionForward searchLimsSpecs(ActionMapping mapping,
        ActionForm form, HttpServletRequest request,
        HttpServletResponse response) {
    	return null;
    }

    /**
     * Search SQUIT specs. Paging is supported, and 20 records will be shown on each page.
     * The SQUIT spec can be filtered by spec code, name, and element.
     *
     * #Param
     * mapping - the action mapping.
     * form - the action form.
     * request - the http servlet request.
     * response - the http servlet response.
     *
     * #Return - the action forward.
     *
     * #Exception
     * throw IllegalArgumentException if any argument is null.
     * throw SpecMappingActionException if any error occurs in DBO operation.
     *
     * #Impl
     * Extract the following request parameters: "specCode" - the spec code, optional, can be any value."specName" - the spec name, optional, can be any value."element" - the spec element, optional, can be any value."pageNo" - the current page number, starting from 0. optional. Use 0 instead if it's missing or it's not integer value or it's negative integer.
     *
     * Create filter = new SpecFilter();
     * Assign extracted specCode, specName, element parameter values to namesake fields in filter.
     * Note that the extracted specCode, specName, and element can be null or empty string.
     *
     * Call result = squitSpecDBO.getSpecList(filter, 20, the-pageNo-value) to get matched LIMS specs.
     * Call request.setAttribute("specs", result.getSpecList());
     * Call request.setAttribute("totalCount", new Integer(result.getTotalCount()));
     * Call request.setAttribute("pageNo", the-pageNo-value);
     *
     * Return mapping.findForward("searchSquitSpecs");
     * @param response
     * @param form
     * @param request
     * @param Return
     * @param mapping
     * @return
    */
    public ActionForward searchSquitSpecs(ActionMapping mapping,
        ActionForm form, HttpServletRequest request,
        HttpServletResponse response) {
        return null;
    }

    /**
     * Search Spec Mappings. Paging is supported, and 20 records will be shown on each page.
     * The spec mappings can be filtered by SQUIT's spec code, name, and element; and LIMS' spec code, name, and element.
     *
     * #Param
     * mapping - the action mapping.
     * form - the action form.
     * request - the http servlet request.
     * response - the http servlet response.
     *
     * #Return - the action forward.
     *
     * #Exception
     * throw IllegalArgumentException if any argument is null.
     * throw SpecMappingActionException if any error occurs in DBO operation.
     *
     * #Impl
     * Extract the following request parameters: "squitSpecCode" - the SQUIT spec code, optional, can be any value."squitSpecName" - the SQUIT spec name, optional, can be any value."squitElement" - the SQUIT spec element, optional, can be any value."limsSpecCode" - the LIMS spec code, optional, can be any value."limsSpecName" - the LIMS spec name, optional, can be any value."limsElement" - the LIMS spec element, optional, can be any value."pageNo" - the current page number, optional. Starting from 0. Use 0 instead if it's missing or it's not integer value or it's negative integer.
     *
     * Create filter = new SpecMapFilter();
     * Assign extracted squitSpecCode, squitSpecName, squitElement, limsSpecCode, limsSpecName, limsElement parameter values to namesake fields in filter.
     * Note that the extracted parameter values can be null or empty string.
     *
     * Call result = limsSpecDBO.getSpecMapList(filter, 20, the-pageNo-value) to get matched spec maps.
     * Call request.setAttribute("specMaps", result.getSpecMapList());
     * Call request.setAttribute("totalCount", new Integer(result.getTotalCount()));
     * Call request.setAttribute("pageNo", the-pageNo-value);
     *
     * Return mapping.findForward("searchSpecMappings");
     * @param response
     * @param form
     * @param request
     * @param Return
     * @param mapping
     * @return
    */
    public ActionForward searchSpecMappings(ActionMapping mapping,
        ActionForm form, HttpServletRequest request,
        HttpServletResponse response) {
        return null;
    }

    /**
     * Delete spec mappings.  If the spec mappings are deleted successfully, it will be redirect to the page showing all the spec mappings.
     *
     * #Param
     * mapping - the action mapping.
     * form - the action form.
     * request - the http servlet request.
     * response - the http servlet response.
     *
     * #Return - the action forward.
     *
     * #Exception
     * throw IllegalArgumentException if any argument is null.
     * throw SpecMappingActionException if any error occurs in DBO operation,
     *               or specMapId parameter values cannot be converted to long values.
     *
     * #Impl
     * Extract the following request parameters: "specMapId" - the spec map ids, optional, it has an array of values, each value means a spec map unique id.
     *
     * Convert all specMapId values into long data type, and store into a local specMapIds variable (of long[] type).
     * Return null if the specMapIds array is null.
     *
     * Call limsSpecDBO.deleteSpecMaps(specMapIds);
     * Return mapping.findForward("viewSpecMappings");
     * @param response
     * @param form
     * @param request
     * @param Return
     * @param mapping
     * @return
    */
    public ActionForward deleteSpecMappings(ActionMapping mapping,
        ActionForm form, HttpServletRequest request,
        HttpServletResponse response) {
        return null;
    }

    /**
     * Edit (add or update) spec mapping.
     * A new spec map is inserted into persistence if user tries to add.
     * The existing spec map is updated if user tries to update.
     *
     * #Param
     * mapping - the action mapping.
     * form - the action form.
     * request - the http servlet request.
     * response - the http servlet response.
     *
     * #Return - the action forward.
     *
     * #Exception
     * throw IllegalArgumentException if any argument is null.
     * throw SpecMappingActionException if any error occurs in DBO operation.
     *
     * #Impl
     * Extract the following request parameters:"action" - its value should be "add" or "update""squitSpecCode" - the SQUIT spec code, required. must be non-null/non-empty string."squitSpecName" - the SQUIT spec name, required. must be non-null/non-empty string."squitElement" - the SQUIT spec element, required.  must be non-null/non-empty string."squitUnit" - the SQUIT unit, required. must be non-null/non-empty string."limsSpecCode" - the LIMS spec code, required.  must be non-null/non-empty string."limsSpecName" - the LIMS spec name, required. must be non-null/non-empty string."limsElement" - the LIMS spec element, required. must be non-null/non-empty string."newUnit" - the new unit. required.  must be non-null/non-empty string."operation" - the operation. required. must be "None", "Multiply" or "Divide". It should be converted to corresponding Operation enum value."operand" - the operand. optional. It should be a double value if present. If the "operation" value is "Divide", it cannot be 0.
     *
     * Create specMap = new SpecMap();
     * Assign the extracted values above to the namesake fields in specMap.
     *
     * If any request parameter fails validation
     *      Add the validation errors into action.
     *      Call request.setAttribute("action", action);
     *      Call request.setAttribute("specMap", specMap);
     *      Return mapping.findForward("openSpecMapping") to forward to the INPUT page.
     * EndIf
     *
     * If limsSpecDBO.existsSpecMap(specMap)
     *      Add "spec map already exists" error message to action.
     *      Call request.setAttribute("action", action);
     *      Call request.setAttribute("specMap", specMap);
     *      Return mapping.findForward("openSpecMapping") to forward to the INPUT page.
     * EndIf
     *
     * If action is "add"
     *      limsSpecDBO.insertSpecMap(specMap)
     * Else
     *      limsSpecDBO.updateSpecMap(specMap)
     * EndIf
     *
     * Return mapping.findForward("viewSpecMappings");
     * @param response
     * @param form
     * @param request
     * @param Return
     * @param mapping
     * @return
    */
    public ActionForward editSpecMapping(ActionMapping mapping,
        ActionForm form, HttpServletRequest request,
        HttpServletResponse response) {
        return null;
    }

    /**
     * Open spec mapping for edit (add or update).
     * A blank page is displayed if user tries to add a new spec map.
     * Otherwise, the selected spec map is displayed for update.
     *
     * #Param
     * mapping - the action mapping.
     * form - the action form.
     * request - the http servlet request.
     * response - the http servlet response.
     *
     * #Return - the action forward.
     *
     * #Exception
     * throw IllegalArgumentException if any argument is null.
     * throw SpecMappingActionException if any error occurs in DBO operation.
     *                     or the request parameters fail validation.
     *
     * #Impl
     * Extract the following request parameters: "action" - its value should be "add" or "update". "specMapId" - it's only available if the "action" parameter's value is "update".  It means the id of the spec map to be updated. should be converted to a long value.
     *
     * If action is "update"
     *      specMap = limsSpecDBO.getSpecMap(specMapId);
     * Else
     *      specMap = new SpecMap();
     * EndIf
     *
     * Call request.setAttribute("action", action);
     * Call request.setAttribute("specMap", specMap);
     * Return mapping.findForward("openSpecMapping");
     * @param response
     * @param form
     * @param request
     * @param Return
     * @param mapping
     * @return
    */
    public ActionForward openSpecMappingForEdit(ActionMapping mapping,
        ActionForm form, HttpServletRequest request,
        HttpServletResponse response) {
        return null;
    }
}
