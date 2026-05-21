using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_9rand_nextE")]
[DemangledName("__llvm_libc_20_1_2_::rand_next")]
internal static partial class Llvm_libc_20_1_2_rand_next
{
	[FixedAddressValueType]
	private static Llvm_libc_20_1_2_fputil_internal_FPStorage_v3nexn __value;

	public unsafe static Llvm_libc_20_1_2_fputil_internal_FPStorage_v3nexn* Pointer => unchecked((Llvm_libc_20_1_2_fputil_internal_FPStorage_v3nexn*)Unsafe.AsPointer(ref __value));

	public static Llvm_libc_20_1_2_fputil_internal_FPStorage_v3nexn Value
	{
		get
		{
			return __value;
		}
		set
		{
			__value = value;
		}
	}

	unsafe static Llvm_libc_20_1_2_rand_next()
	{
		Value = new Llvm_libc_20_1_2_fputil_internal_FPStorage_v3nexn
		{
			Val = 1L
		};
		PointerIndices.Register(Pointer);
	}
}
