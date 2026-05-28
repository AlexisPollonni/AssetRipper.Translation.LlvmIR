using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fpathconf
{
	[MangledName("fpathconf")]
	[DemangledName("fpathconf")]
	public unsafe static long Invoke([MangledName("fd")] int Fd, [MangledName("name")] int Name)
	{
		long result = 0L;
		Cpp_optional_qbe95b cpp_optional_qbe95b = default(Cpp_optional_qbe95b);
		Llvm_lifetime_start_p0.Invoke(128L, &cpp_optional_qbe95b);
		Llvm_memset_p0_i64.Invoke(&cpp_optional_qbe95b, -86, 128L, isVolatile: false);
		Statfs_utils_linux_fstatfs.Invoke(&cpp_optional_qbe95b, Fd);
		int num;
		if (Optional_statfs_ToBoolean.Invoke(&cpp_optional_qbe95b))
		{
			result = Pathconfig.Invoke(Optional_statfs_value.Invoke(&cpp_optional_qbe95b), Name);
			num = 1;
		}
		else
		{
			num = 0;
		}
		Llvm_lifetime_end_p0.Invoke(128L, &cpp_optional_qbe95b);
		switch (num)
		{
		case 0:
			result = -1L;
			goto case 1;
		case 1:
			return result;
		default:
			throw new NotImplementedException("Reached LLVM unreachable instruction.");
		}
	}
}
