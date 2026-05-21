using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_load_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_4loadIjEET_PKNS_3cpp4byteE")]
	[DemangledName("unsigned int __llvm_libc_20_1_2_::load<unsigned int>(__llvm_libc_20_1_2_::cpp::byte const*)")]
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([MangledName("ptr")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* Ptr)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = -1431655766;
		Llvm_libc_20_1_2_memcpy_inline_4ul.Invoke(&num, Ptr);
		int result = num;
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
