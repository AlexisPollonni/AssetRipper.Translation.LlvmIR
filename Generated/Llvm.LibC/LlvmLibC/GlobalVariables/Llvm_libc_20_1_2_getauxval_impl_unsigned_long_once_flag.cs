using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZZN19__llvm_libc_20_1_2_18__getauxval_impl__EmE9once_flag")]
[DemangledName("__llvm_libc_20_1_2_::__getauxval_impl__(unsigned long)::once_flag")]
internal static partial class Llvm_libc_20_1_2_getauxval_impl_unsigned_long_once_flag
{
	private partial struct __WrapperType
	{
		public int __value;
	}

	[FixedAddressValueType]
	private static __WrapperType __value;

	public unsafe static int* Pointer => unchecked((int*)Unsafe.AsPointer(ref __value));

	public static int Value
	{
		get
		{
			return __value.__value;
		}
		set
		{
			__value.__value = value;
		}
	}

	unsafe static Llvm_libc_20_1_2_getauxval_impl_unsigned_long_once_flag()
	{
		PointerIndices.Register(Pointer);
	}
}
