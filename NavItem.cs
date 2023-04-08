using Statiq.Common;

namespace Seluga; 

public class NavItem {
	public IDocument? Previous { get; set; }
	public IDocument? Next { get; set; }
	public bool IsPost { get; set; }
	public bool IsArchive { get; set; }
}
