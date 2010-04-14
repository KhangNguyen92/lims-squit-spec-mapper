/**
 *
 * Copyright (c) 2010, TopCoder, Inc. All rights reserved
 */
package com.ibm.lims;

import junit.framework.Test;
import junit.framework.TestCase;
import junit.framework.TestSuite;
import com.ibm.lims.accuracytests.AccuracyTests;
import com.ibm.lims.failuretests.FailureTests;
import com.ibm.lims.stresstests.StressTests;

/**
 * <p>This test case aggregates all test cases.</p>
 *
 * @author TopCoder
 * @version 1.0
 */
public class AllTests extends TestCase {

    public static Test suite() {
        final TestSuite suite = new TestSuite();
        
        //unit tests
        suite.addTest(UnitTests.suite());
        
        //accuracy tests
        suite.addTest(AccuracyTests.suite());
        
        //failure tests
        suite.addTest(FailureTests.suite());
        
        //stress tests
        suite.addTest(StressTests.suite());
        
        return suite;
    }

}
