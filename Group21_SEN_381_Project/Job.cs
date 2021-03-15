using System;

public class Job
{
    private int jobRef;
    private bool jobStatus;
    private string[] abilityReq;


    public int JobRef
    {
        get { return jobRef; }
        set { jobRef = value; }
    }

    public bool JobStatus
    {
        get { return jobStatus; }
        set { jobStatus = value; }
    }

    public string[] AbilityReq
    {
        get { return abilityReq; }
    }

    public void Job()
    {
    }

    public void Job(int jobRef, bool jobStatus, string[] abilityReq)
    {
        jobRef = this.jobRef;
        jobStatus = this.jobRef;
        abilityReq = this.abilityReq;
    }

    public void CheckRequirements()
    {
    }

}
