using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Wait
{
	[MangledName("wait")]
	[DemangledName("wait")]
	public unsafe static int Invoke([MangledName("wait_status")] void* Wait_status)
	{
		Cpp_optional_int_OptionalStorage cpp_optional_int_OptionalStorage = default(Cpp_optional_int_OptionalStorage);
		Llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_int_OptionalStorage);
		unchecked
		{
			*(int*)(&cpp_optional_int_OptionalStorage) = -1431655766;
			((sbyte*)(&cpp_optional_int_OptionalStorage))[4] = -86;
			sbyte* ptr = (sbyte*)(&cpp_optional_int_OptionalStorage) + 5;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			*(InlineArray5_Byte*)(&cpp_optional_int_OptionalStorage) = NumericHelper.TruncOrZextToBytes<long, InlineArray5_Byte>(Internal_wait4impl.Invoke(-1, Wait_status, 0, null));
			int result;
			if (!Expected_int_int_has_value.Invoke(&cpp_optional_int_OptionalStorage))
			{
				Errno_Assignment.Invoke(A: *(int*)Expected_int_int_error.Invoke(&cpp_optional_int_OptionalStorage), This: Libc_errno.Pointer);
				result = -1;
			}
			else
			{
				result = *(int*)Expected_int_int_value.Invoke(&cpp_optional_int_OptionalStorage);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_int_OptionalStorage);
			return result;
		}
	}
}
