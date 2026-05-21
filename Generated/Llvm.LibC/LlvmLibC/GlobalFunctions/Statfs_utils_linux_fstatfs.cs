using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Statfs_utils_linux_fstatfs
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12statfs_utils13linux_fstatfsEi")]
	[DemangledName("__llvm_libc_20_1_2_::statfs_utils::linux_fstatfs(int)")]
	public unsafe static void Invoke([MangledName("agg.result")] Llvm_libc_20_1_2_cpp_optional_qbe95b* Agg_result, [MangledName("fd")][NativeType("int")] int Fd)
	{
		Statfs statfs = default(Statfs);
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(120L, &statfs);
		Llvm_memset_p0_i64.Invoke(&statfs, -86, 120L, isVolatile: false);
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Llvm_libc_20_1_2_syscall_impl_int_int_statfs.Invoke(138L, Fd, &statfs);
		if (num < 0)
		{
			Errno_Assignment.Invoke(A: -num, This: Llvm_libc_20_1_2_libc_errno.Pointer);
			Optional_statfs_Constructor.Invoke(Agg_result);
		}
		else
		{
			statfs.F_flags &= -33L;
			Optional_statfs_Constructor.Invoke(Agg_result, &statfs);
		}
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_lifetime_end_p0.Invoke(120L, &statfs);
	}
}
