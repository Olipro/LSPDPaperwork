namespace LSPDPaperwork {
    public enum RejectionState : int {
        NONE = -1,
        AMENDIT,
        REAPPLY,
        TMPCRIM,
        FOREVER,
    }
    public interface IRejection {
        string Code { get; }
        string Desc { get; }
        string Reason { get; }
        RejectionState Type { get; }
    }
}
