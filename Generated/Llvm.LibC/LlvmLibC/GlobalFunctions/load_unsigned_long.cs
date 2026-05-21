using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class load_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_4loadImEET_PKNS_3cpp4byteE")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::load<unsigned long>(__llvm_libc_20_1_2_::cpp::byte const*)")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* ptr)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = -6148914691236517206L;
		memcpy_inline_8ul.Invoke(&num, ptr);
		long result = num;
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
