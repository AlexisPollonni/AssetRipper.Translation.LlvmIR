using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_get_fileno
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10get_filenoEPNS_4FileE")]
	[DemangledName("__llvm_libc_20_1_2_::get_fileno(__llvm_libc_20_1_2_::File*)")]
	public unsafe static int Invoke([MangledName("f")][NativeType("__llvm_libc_20_1_2_::File*")] Llvm_libc_20_1_2_File_sjnxn4* F)
	{
		void* ptr = null;
		Llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = F;
		int result = LinuxFile_get_fd.Invoke(unchecked((Llvm_libc_20_1_2_LinuxFile*)ptr));
		Llvm_lifetime_end_p0.Invoke(8L, &ptr);
		return result;
	}
}
