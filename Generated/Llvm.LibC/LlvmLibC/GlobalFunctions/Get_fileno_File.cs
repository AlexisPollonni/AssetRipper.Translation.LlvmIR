using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10get_filenoEPNS_4FileE")]
[DemangledName("__llvm_libc_20_1_2_::get_fileno(__llvm_libc_20_1_2_::File*)")]
internal static partial class Get_fileno_File
{
	public unsafe static int Invoke(File_sjnxn4* f)
	{
		void* ptr = null;
		llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = f;
		int result = LinuxFile_get_fd_const.Invoke(unchecked((LinuxFile*)ptr));
		llvm_lifetime_end_p0.Invoke(8L, &ptr);
		return result;
	}
}
