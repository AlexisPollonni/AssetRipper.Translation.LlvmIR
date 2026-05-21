using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Wait4
{
	[MangledName("wait4")]
	[DemangledName("wait4")]
	public unsafe static int Invoke([MangledName("pid")] int Pid, [MangledName("wait_status")] void* Wait_status, [MangledName("options")] int Options, [MangledName("usage")] void* Usage)
	{
		Llvm_libc_20_1_2_cpp_optional_int_OptionalStorage llvm_libc_20_1_2_cpp_optional_int_OptionalStorage = default(Llvm_libc_20_1_2_cpp_optional_int_OptionalStorage);
		Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_int_OptionalStorage);
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_cpp_optional_int_OptionalStorage) = -1431655766;
			((sbyte*)(&llvm_libc_20_1_2_cpp_optional_int_OptionalStorage))[4] = -86;
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_int_OptionalStorage) + 5;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			*(InlineArray5_Byte*)(&llvm_libc_20_1_2_cpp_optional_int_OptionalStorage) = NumericHelper.TruncOrZextToBytes<long, InlineArray5_Byte>(Internal_wait4impl.Invoke(Pid, Wait_status, Options, Usage));
			int result;
			if (!Expected_int_int_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_int_OptionalStorage))
			{
				Errno_Assignment.Invoke(A: *(int*)Expected_int_int_error.Invoke(&llvm_libc_20_1_2_cpp_optional_int_OptionalStorage), This: Llvm_libc_20_1_2_libc_errno.Pointer);
				result = -1;
			}
			else
			{
				result = *(int*)Expected_int_int_value.Invoke(&llvm_libc_20_1_2_cpp_optional_int_OptionalStorage);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_int_OptionalStorage);
			return result;
		}
	}
}
