package com.ibm.lims.valueobject;

import java.sql.Date;

import com.ibm.lims.businesslogic.ResultValidator;


public class TestDetailsVO 
{

	private String SupplierResults;
	private String Test;  	
	private String Status;  	
	private String Element;  	
	private String Run;  	
	private String Result;  	
	private String Units;  	
	private String CompletionID; 	
	private String ApprovalDate; 	
	private String ApprovalTime; 	
	private String DueDate; 	
	private String Priority;
	private String ResultType;
	private String HighLimits;
	private String LowLimits;
	private String SampleNo;
	private String ResultCode; 
	private String TestCode;
	private String TestSuffix;
	private boolean comp;
	private boolean app;
	private boolean rel;
	private String SampleID;
	private String Dept;
	private String Sect;
	private Date tstcomdate;
	private java.util.Date comdate;
	private String testseqno; 
	private String type;
	private String Supplier;
	private String lotno;
	private String SampleSta;
	private String OutOfLimit="";
	private String elseqonumber;
	private String lotsamplestatus;
	private boolean outoflimit=false;
	private boolean process;	
	private String subNo;
	private String specind;
	private String rmt; 
	private String rmtallsupp;
	private String spltextcom; 
	private String typeresult;
	private String teststa;
	private String empid;
	private int ntests;
	private boolean resultoutoflimit;
	private String user;
	private boolean ischecked=false;
	private int totalruns;
	private String runno;
	private boolean iselected;
	private double tseqno;
	private double telseqno;
	private boolean checked;
	private int ID;
	private String jobNo;
	private String submname;
	private int pricode;
	
	public String getUID()
	{
		return getSampleNo() + " "    +getTestCode() + " " + getTestSuffix() + " " + getElement();
	}
	
	public String getSID()
	{
		return getSampleNo() + " "    + getTestCode() + " " + getTestSuffix() + " " + getSampleID();
	}
	
	public int getID() 
	{
		if(ID!=0)
			return ID;
		else
			return  this.hashCode();
	}

	public void setID(int id) {
		ID = id;
	}

	public boolean resultsOutLimit() throws Exception
	{
		ResultValidator rv = new ResultValidator();
		boolean out = rv.validateResults(this.Units, this.Result, this.HighLimits, this.LowLimits);
		if(out)
			return out;
		else
		{
			out = rv.validateResults(this.Units, this.SupplierResults, this.HighLimits, this.LowLimits);
			return out;	
		}
	}
	
	public boolean isEqual(TestDetailsVO td)
	{
		 if(this.TestCode.equalsIgnoreCase(td.getTestCode()))
		 	if(this.TestSuffix.equalsIgnoreCase(td.getTestSuffix()))	
		 		if(this.Element.equalsIgnoreCase(td.getElement()))
		 			if(this.runno == td.getRunno())
		 				return true;
		 	return false;
	}
	
	public TestDetailsVO(TestDetailsVO td) throws Exception
	{
		this.SampleNo = td.getSampleNo();
		this.Units = td.getUnits();
		this.Element = td.getElement();
		this.TestCode = td.getTestCode();
		this.Test = td.getTest();
	    this.TestSuffix = td.getTestSuffix();
		this.ResultType	= td.getResultType();
		this.SupplierResults = td.getSupplierResults();
		this.HighLimits = td.getHighLimits();
		this.LowLimits = td.getLowLimits();
		this.Status	= td.getStatus();
		this.Priority= td.getPriority();				
		this.DueDate =	td.getDueDate();
		this.setTelseqno(td.getTelseqno());
		this.setTseqno(td.getTseqno());
	}

	
	
	public TestDetailsVO() throws Exception {
		super();	
		this.Element = null;
		this.Units = null;
		this.Run = null;
	}
	
	
	public boolean isApp() {
		return app;
	}
	public void setApp(boolean app) {
		this.app = app;
	}
	
	public void setApprovalDate(String approvalDate) {
		ApprovalDate = approvalDate;
	}
	
	public void setApprovalTime(String approvalTime) {
		ApprovalTime = approvalTime;
	}
	public boolean isChecked() {
		return checked;
	}
	public void setChecked(boolean checked) {
		this.checked = checked;
	}
	public java.util.Date getComdate() {
		return comdate;
	}
	public void setComdate(java.util.Date comdate) {
		this.comdate = comdate;
	}
	public boolean isComp() {
		return comp;
	}
	public void setComp(boolean comp) {
		this.comp = comp;
	}
	
	public void setCompletionID(String completionID) {
		CompletionID = completionID;
	}
	
	public void setDept(String dept) {
		Dept = dept;
	}
	
	public void setDueDate(String dueDate) {
		DueDate = dueDate;
	}
	
	public void setElement(String element) {
		Element = element;
	}
	
	public void setElseqonumber(String elseqonumber) {
		this.elseqonumber = elseqonumber;
	}
	
	public void setEmpid(String empid) {
		this.empid = empid;
	}
	
	public void setHighLimits(String highLimits) {
		HighLimits = highLimits;
	}
	public boolean isIschecked() {
		return ischecked;
	}
	public void setIschecked(boolean ischecked) {
		this.ischecked = ischecked;
	}
	public boolean isIselected() {
		return iselected;
	}
	public void setIselected(boolean iselected) {
		this.iselected = iselected;
	}
	
	public void setLotno(String lotno) {
		this.lotno = lotno;
	}
	
	public void setLotsamplestatus(String lotsamplestatus) {
		this.lotsamplestatus = lotsamplestatus;
	}
	
	public void setLowLimits(String lowLimits) {
		LowLimits = lowLimits;
	}
	public int getNtests() {
		return ntests;
	}
	public void setNtests(int ntests) {
		this.ntests = ntests;
	}
	public boolean isOutoflimit() {
		return outoflimit;
	}
	public void setOutoflimit(boolean outoflimit) {
		this.outoflimit = outoflimit;
	}
	
	public void setOutOfLimit(String outOfLimit) {
		OutOfLimit = outOfLimit;
	}
	
	public void setPriority(String priority) {
		Priority = priority;
	}
	public boolean isProcess() {
		return process;
	}
	public void setProcess(boolean process) {
		this.process = process;
	}
	public boolean isRel() {
		return rel;
	}
	public void setRel(boolean rel) {
		this.rel = rel;
	}
	
	public void setResult(String result) {
		Result = result;
	}
	
	public void setResultCode(String resultCode) {
		ResultCode = resultCode;
	}
	public boolean isResultoutoflimit() {
		return resultoutoflimit;
	}
	public void setResultoutoflimit(boolean resultoutoflimit) {
		this.resultoutoflimit = resultoutoflimit;
	}
	
	public void setResultType(String resultType) {
		ResultType = resultType;
	}
	
	public void setRmt(String rmt) {
		this.rmt = rmt;
	}
	
	public void setRmtallsupp(String rmtallsupp) {
		this.rmtallsupp = rmtallsupp;
	}
	
	public void setRun(String run) {
		Run = run;
	}
	public String getRunno() {
		return runno;
	}
	public void setRunno(String runno) {
		this.runno = runno;
	}
	
	public void setSampleID(String sampleID) {
		SampleID = sampleID;
	}
	public String getSampleNo() 
	{
		if(SampleNo!=null)
			return SampleNo;
		else
			return "";
	}
	public void setSampleNo(String sampleNo) {
		SampleNo = sampleNo;
	}
	
	public void setSampleSta(String sampleSta) {
		SampleSta = sampleSta;
	}
	
	public void setSect(String sect) {
		Sect = sect;
	}
	
	public void setSpecind(String specind) {
		this.specind = specind;
	}
	
	public void setSpltextcom(String spltextcom) {
		this.spltextcom = spltextcom;
	}
	
	public void setStatus(String status) {
		Status = status;
	}
	
	public void setSubNo(String subNo) {
		this.subNo = subNo;
	}
	
	public void setSupplier(String supplier) {
		Supplier = supplier;
	}
	
	public void setSupplierResults(String supplierResults) {
		SupplierResults = supplierResults;
	}
	public double getTelseqno() {
		return telseqno;
	}
	public void setTelseqno(double telseqno) {
		this.telseqno = telseqno;
	}
	
	public void setTest(String test) {
		Test = test;
	}
	
	public void setTestCode(String testCode) {
		TestCode = testCode;
	}
	
	public void setTestseqno(String testseqno) {
		this.testseqno = testseqno;
	}
	
	public void setTeststa(String teststa) {
		this.teststa = teststa;
	}
	
	public void setTestSuffix(String testSuffix) {
		TestSuffix = testSuffix;
	}
	public int getTotalruns() {
		return totalruns;
	}
	public void setTotalruns(int totalruns) {
		this.totalruns = totalruns;
	}
	public double getTseqno() {
		return tseqno;
	}
	public void setTseqno(double tseqno) {
		this.tseqno = tseqno;
	}
	public Date getTstcomdate() {
		return tstcomdate;
	}
	public void setTstcomdate(Date tstcomdate) {
		this.tstcomdate = tstcomdate;
	}
	
	public void setType(String type) {
		this.type = type;
	}
	
	public void setTyperesult(String typeresult) {
		this.typeresult = typeresult;
	}
	
	public void setUnits(String units) {
		Units = units;
	}
	
	public String getUser() {
		if(user!=null)
		return user;
		return "";
	}

	public void setUser(String user) {
		this.user = user;
	}

	/**
	 * @return
	 */
	public String getTyperesult() {
		if(typeresult!=null)
		return typeresult;
		return "";
	}

	/**
	 * @return
	 */
	public String getTeststa() {
		if(teststa!=null)
		return teststa;
		return "";
	}

	/**
	 * @return
	 */
	public String getEmpid() {
		if( empid !=null)
		return empid;
		return "";
	}

	/**
	 * @return
	 */
	public String getRmt() {
		if(rmt!=null)
		return rmt;
		return "";
	}

	/**
	 * @return
	 */
	public String getRmtallsupp() {
		if(rmtallsupp!=null)
		return rmtallsupp;
		return "";
	}

	/**
	 * @return
	 */
	public String getSpecind() {
		if(specind!=null)
		return specind;
		return "";
	}

	/**
	 * @return
	 */
	public String getSpltextcom() {
		if(spltextcom!=null)
		return spltextcom;
		return "";
	}

	/**
	 * @return
	 */
	public String getOutOfLimit() {
		if(OutOfLimit!=null)
		return OutOfLimit;
		return "";
	}
	

	/**
	 * @return
	 */
	public String getElseqonumber() {
		if(elseqonumber!=null)
		return elseqonumber;
		return "";
	}


	/**
	 * @return
	 */
	public String getLotsamplestatus() {
		if(lotsamplestatus!=null)
		return lotsamplestatus;
		return "";
	}


	/**
	 * @return
	 */
	public String getSubNo() {
		if(subNo!=null)
		return subNo;
		return "";
	}

	/**
	 * @return
	 */
	public String getTestseqno() {
		if(testseqno!=null)
		return testseqno;
		return "";
	}


	/**
	 * @return
	 */
	public String getType() {
		if( type!=null)
		return type;
		return "";
	}

	/**
	 * @return
	 */
	public String getSupplier() {
		if(Supplier!=null)
		return Supplier;
		return "";
	}


	/**
	 * @return
	 */
	public String getLotno() {
		if(lotno!=null)
		return lotno;
		return "";
	}


	/**
	 * @return
	 */
	public String getSampleSta() {
		if(SampleSta!=null)
		return SampleSta;
		return "";
	}

	/**
	 * @return
	 */
	public String getResultCode() 
	{
		if(ResultCode!=null)
		return ResultCode;
		return "";
	}


	/**
	 * @return
	 */
	public String getTestCode() 
	{
		if(TestCode!=null)
		return TestCode;
		return "";
	}

	/**
	 * @return
	 */
	public String getTestSuffix() 
	{
		if(TestSuffix==null)
			return "";
		return TestSuffix;
	}


	/**
	 * @return
	 */
	public String getSampleID() {
		if(SampleID!=null)
		return SampleID;
		return "";
	}


	/**
	 * @return
	 */
	public String getDept() {
		if( Dept!=null)
		return Dept;
		return "";
	}

	/**
	 * @return
	 */
	public String getSect() {
		if(Sect!=null)
		return Sect;
		return "";
	}


	/**
	 * @return
	 */
	public String getApprovalDate() 
	{
		if(ApprovalDate!=null)
		return ApprovalDate;
		return "";
	}

	/**
	 * @return
	 */
	public String getApprovalTime() 
	{
		if(ApprovalTime!=null)
			return ApprovalTime;
		return "";
	}

	/**
	 * @return
	 */
	public String getCompletionID() 
	{
		if(CompletionID!=null)
		return CompletionID;
		return "";
	}

	/**
	 * @return
	 */
	public String getDueDate() 
	{
		if( DueDate!=null)
		return DueDate;
		return "";
	}

	/**
	 * @return
	 */
	public String getElement() 
	{
		if(Element!=null)
		return Element;
		return "";
	}

	/**
	 * @return
	 */
	public String getPriority() 
	{
		if( Priority!=null)
		return Priority;
		return "";
	}

	/**
	 * @return
	 */
	public String getResult() 
	{
		if(Result!=null)
		return Result;
		return "";
	}

	/**
	 * @return
	 */
	public String getResultType() 
	{
		if(ResultType!=null)
		return ResultType;
		return "";
	}

	/**
	 * @return
	 */
	public String getRun() 
	{
		if( Run!=null)
		return Run;
		return "0";
	}

	/**
	 * @return
	 */
	public String getStatus() 
	{
		if(Status!=null)
		{
			return Status;
		}
		return "";
	}

	/**
	 * @return
	 */
	public String getSupplierResults() 
	{
		if(SupplierResults!=null)
		return SupplierResults;
		return "";
	}

	/**
	 * @return
	 */
	public String getTest() 
	{
		if(Test!=null)
		return Test;
		return "";
	}

	/**
	 * @return
	 */
	public String getUnits() 
	{
		if(Units!=null)
		return Units;
		return "";
	}

	/**
	 * @return
	 */
	public String getHighLimits() 
	{
		if(HighLimits!=null)
		return HighLimits;
		return "";
	}

	/**
	 * @return
	 */
	public String getLowLimits() 
	{
		if(LowLimits!=null)
		return LowLimits;
		return "";
	}

	public String getJobNo() {
		return jobNo;
	}

	public void setJobNo(String jobNo) {
		this.jobNo = jobNo;
	}

	public String getSubmname() {
		return submname;
	}

	public void setSubmname(String submname) {
		this.submname = submname;
	}

	public int getPricode() {
		return pricode;
	}

	public void setPricode(int pricode) {
		this.pricode = pricode;
	}



	
}
