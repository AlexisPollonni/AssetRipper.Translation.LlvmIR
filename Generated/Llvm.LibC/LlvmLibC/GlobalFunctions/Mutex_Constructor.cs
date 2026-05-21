using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Mutex_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_5MutexC2Ebbbb")]
	[DemangledName("__llvm_libc_20_1_2_::Mutex::Mutex(bool, bool, bool, bool)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_Mutex* This, [MangledName("is_timed")][NativeType("bool")] bool Is_timed, [MangledName("is_recursive")][NativeType("bool")] bool Is_recursive, [MangledName("is_robust")][NativeType("bool")] bool Is_robust, [MangledName("is_pshared")][NativeType("bool")] bool Is_pshared)
	{
		sbyte b = (Is_timed ? ((sbyte)1) : ((sbyte)0));
		sbyte b2 = (Is_recursive ? ((sbyte)1) : ((sbyte)0));
		sbyte b3 = (Is_robust ? ((sbyte)1) : ((sbyte)0));
		sbyte b4 = (Is_pshared ? ((sbyte)1) : ((sbyte)0));
		RawMutex_Constructor.Invoke(This);
		This->Timed = (((b & 1) == 1) ? ((sbyte)1) : ((sbyte)0));
		This->Recursive = (((b2 & 1) == 1) ? ((sbyte)1) : ((sbyte)0));
		This->Robust = (((b3 & 1) == 1) ? ((sbyte)1) : ((sbyte)0));
		This->Pshared = (((b4 & 1) == 1) ? ((sbyte)1) : ((sbyte)0));
		This->Owner = 0;
		This->Lock_count = 0L;
	}
}
