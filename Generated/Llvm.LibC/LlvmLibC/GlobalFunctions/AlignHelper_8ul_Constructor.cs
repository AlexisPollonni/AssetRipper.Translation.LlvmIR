using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class AlignHelper_8ul_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11AlignHelperILm8EEC2EPKNS_3cpp4byteE")]
	[DemangledName("__llvm_libc_20_1_2_::AlignHelper<8ul>::AlignHelper(__llvm_libc_20_1_2_::cpp::byte const*)")]
	public unsafe static void Invoke(void* @this, [NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* ptr)
	{
		unchecked((fputil_internal_FPStorage_v3nexn*)@this)->val = distance_to_next_aligned_8ul.Invoke(ptr);
	}
}
