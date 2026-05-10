using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10get_filenoEPNS_4FileE")]
[DemangledName("__llvm_libc_20_1_2_::get_fileno(__llvm_libc_20_1_2_::File*)")]
internal static partial class Get_fileno_File
{
	public unsafe static int Invoke(void* f)
	{
		void* ptr = null;
		llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = f;
		int result = LinuxFile_get_fd_const.Invoke(ptr);
		llvm_lifetime_end_p0.Invoke(8L, &ptr);
		return result;
	}
}
