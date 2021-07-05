namespace ComputerFulfilment
{
    public enum ComputerStatus
    {
        NotStarted, /*All Parts are in not started state*/
        InProgress, /*Some Parts have been ordered*/
        Blocked, /* Something has gone wrong, a part can't be order, a shipment was wrong, something horrible has happened and needs manual intervention*/
        PhysicallyComplete, /*All parts installed, but not tested together*/
        DiagnosticsCheckPerformed, /* Booted with Live CD Distro with scripts to test parts*/
        ImagedWithLatestPatchedOS,
        ReadyToSell, /* Everything done and ready to ship */
        Sold
    }
}