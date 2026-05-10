using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_4loadIjEET_PKNS_3cpp4byteE")]
[DemangledName("unsigned int __llvm_libc_20_1_2_::load<unsigned int>(__llvm_libc_20_1_2_::cpp::byte const*)")]
internal static partial class unsigned_int_load_unsigned_int_cpp_byte_const
{
	public unsafe static int Invoke(void* ptr)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = -1431655766;
		void_memcpy_inline_4ul_void_void_const.Invoke(&num, ptr);
		int result = num;
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
