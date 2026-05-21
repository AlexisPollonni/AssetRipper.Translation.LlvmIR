using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class AllocChecker_alloc
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12AllocChecker5allocEmRS0_")]
	[DemangledName("__llvm_libc_20_1_2_::AllocChecker::alloc(unsigned long, __llvm_libc_20_1_2_::AllocChecker&)")]
	public unsafe static void* Invoke([MangledName("s")][NativeType("unsigned long")] long S, [MangledName("ac")][NativeType("__llvm_libc_20_1_2_::AllocChecker&")] void* Ac)
	{
		void* ptr = null;
		Llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = Malloc.Invoke(S);
		AllocChecker_Assignment.Invoke(Ac, ptr != null);
		void* result = ptr;
		Llvm_lifetime_end_p0.Invoke(8L, &ptr);
		return result;
	}
}
