using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class AlignHelper_8ul_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11AlignHelperILm8EEC2EPKNS_3cpp4byteE")]
	[DemangledName("__llvm_libc_20_1_2_::AlignHelper<8ul>::AlignHelper(__llvm_libc_20_1_2_::cpp::byte const*)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("ptr")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* Ptr)
	{
		unchecked((Fputil_internal_FPStorage_v3nexn*)This)->Val = Distance_to_next_aligned_8ul.Invoke(Ptr);
	}
}
