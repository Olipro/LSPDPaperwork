namespace LSPDPaperwork {
    public interface ICrime {
        void AddPrefix(string prefix);
        void DelPrefix(string prefix);
        void AddSuffix(string suffix);
        void DelSuffix(string suffix);
        string Code { get; }
        string Description { get; }
        string Prefix { get; }
        string Suffix { get; }
        bool Equals(string desc);
        void Reset();
    }
}
