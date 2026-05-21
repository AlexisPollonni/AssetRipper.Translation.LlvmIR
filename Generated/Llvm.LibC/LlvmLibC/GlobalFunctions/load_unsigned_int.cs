using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class load_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_4loadIjEET_PKNS_3cpp4byteE")]
	[DemangledName("unsigned int __llvm_libc_20_1_2_::load<unsigned int>(__llvm_libc_20_1_2_::cpp::byte const*)")]
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* ptr)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = -1431655766;
		memcpy_inline_4ul.Invoke(&num, ptr);
		int result = num;
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
