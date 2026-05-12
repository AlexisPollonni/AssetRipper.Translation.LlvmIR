using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_4File12read_allowedEv")]
[DemangledName("__llvm_libc_20_1_2_::File::read_allowed() const")]
internal static partial class File_read_allowed_const
{
	public unsafe static bool Invoke(File_sjnxn4* @this)
	{
		return (@this->mode & 9) != 0;
	}
}
