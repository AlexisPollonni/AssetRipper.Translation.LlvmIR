using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class load_unsigned_short
{
	[MangledName("_ZN19__llvm_libc_20_1_2_4loadItEET_PKNS_3cpp4byteE")]
	[DemangledName("unsigned short __llvm_libc_20_1_2_::load<unsigned short>(__llvm_libc_20_1_2_::cpp::byte const*)")]
	[return: NativeType("unsigned short")]
	public unsafe static short Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* ptr)
	{
		short num = 0;
		llvm_lifetime_start_p0.Invoke(2L, &num);
		num = -21846;
		memcpy_inline_2ul.Invoke(&num, ptr);
		short result = num;
		llvm_lifetime_end_p0.Invoke(2L, &num);
		return result;
	}
}
