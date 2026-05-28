using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class File_read_allowed
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_4File12read_allowedEv")]
	[DemangledName("__llvm_libc_20_1_2_::File::read_allowed() const")]
	public unsafe static bool Invoke([MangledName("this")] File_sjnxn4* This)
	{
		return (This->Mode & 9) != 0;
	}
}
