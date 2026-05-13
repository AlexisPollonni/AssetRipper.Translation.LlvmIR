using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_4loadItEET_PKNS_3cpp4byteE")]
[DemangledName("unsigned short __llvm_libc_20_1_2_::load<unsigned short>(__llvm_libc_20_1_2_::cpp::byte const*)")]
internal static partial class unsigned_short_load_unsigned_short_cpp_byte_const
{
	public unsafe static short Invoke(void* ptr)
	{
		short num = 0;
		llvm_lifetime_start_p0.Invoke(2L, &num);
		num = -21846;
		void_memcpy_inline_2ul_void_void_const.Invoke(&num, ptr);
		short result = num;
		llvm_lifetime_end_p0.Invoke(2L, &num);
		return result;
	}
}
