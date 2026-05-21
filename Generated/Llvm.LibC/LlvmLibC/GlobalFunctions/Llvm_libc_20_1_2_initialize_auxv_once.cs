using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_initialize_auxv_once
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void>)(&Invoke));

	[MangledName("_ZN19__llvm_libc_20_1_2_L20initialize_auxv_onceEv")]
	[DemangledName("__llvm_libc_20_1_2_::initialize_auxv_once()")]
	public unsafe static void Invoke()
	{
		Anon_5uk363 anon_5uk = default(Anon_5uk363);
		void* ptr = null;
		long num = 0L;
		int num2 = 0;
		Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt = default(Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		void* ptr2 = null;
		sbyte b = 0;
		long num3 = 0L;
		if (Cxa_atexit.__pointer == null)
		{
			return;
		}
		Llvm_lifetime_start_p0.Invoke(8L, &anon_5uk);
		int num4;
		int num7;
		unchecked
		{
			*(IntPtr*)(&anon_5uk) = unchecked((nint)(-6148914691236517206L));
			AuxvMMapGuard_Constructor.Invoke(&anon_5uk);
			if (!AuxvMMapGuard_allocated.Invoke(&anon_5uk))
			{
				num4 = 1;
				goto IL_02a8;
			}
			Llvm_lifetime_start_p0.Invoke(8L, &ptr);
			ptr = AuxvMMapGuard_get.Invoke(&anon_5uk);
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = 1016L;
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			long num5 = (long)ptr;
			long num6 = num;
			num2 = ((delegate*<int, long, long, long, long, int>)Prctl.__pointer)(1096112214, num5, num6, 0L, 0L);
			if (num2 >= 0)
			{
				AuxvMMapGuard_submit_to_global.Invoke(&anon_5uk);
				num4 = 1;
				goto IL_0276;
			}
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
			*(int*)(&llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt) = -1431655766;
			AuxvFdGuard_Constructor.Invoke(&llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
			if (!AuxvFdGuard_valid.Invoke(&llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt))
			{
				num4 = 1;
				goto IL_025d;
			}
			Llvm_lifetime_start_p0.Invoke(8L, &ptr2);
			ptr2 = ptr;
			Errno_Assignment.Invoke(Llvm_libc_20_1_2_libc_errno.Pointer, 0);
			Llvm_lifetime_start_p0.Invoke(1L, &b);
			b = 0;
			while (num != 0L)
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = ((delegate*<int, void*, long, long>)Read.__pointer)(AuxvFdGuard_get.Invoke(&llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt), ptr2, num);
				if (num3 <= 0L)
				{
					if (Errno_ToInt32.Invoke(Llvm_libc_20_1_2_libc_errno.Pointer) == 4)
					{
						num4 = 2;
					}
					else
					{
						if (num3 == -1L)
						{
							b = 1;
						}
						num4 = 3;
					}
				}
				else
				{
					ptr2 = (byte*)ptr2 + num3;
					num -= num3;
					num4 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num3);
				num7 = num4;
				if (num7 == 0 || num7 == 2)
				{
					continue;
				}
				goto IL_0216;
			}
			goto IL_0225;
		}
		IL_02d0:
		throw new NotImplementedException("Reached LLVM unreachable instruction.");
		IL_0225:
		if ((b & 1) != 1)
		{
			AuxvMMapGuard_submit_to_global.Invoke(&anon_5uk);
		}
		Llvm_lifetime_end_p0.Invoke(1L, &b);
		Llvm_lifetime_end_p0.Invoke(8L, &ptr2);
		num4 = 0;
		goto IL_025d;
		IL_025d:
		AuxvFdGuard_Destructor.Invoke(&llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		goto IL_0276;
		IL_0276:
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		Llvm_lifetime_end_p0.Invoke(8L, &ptr);
		goto IL_02a8;
		IL_02a8:
		AuxvMMapGuard_Destructor.Invoke(&anon_5uk);
		Llvm_lifetime_end_p0.Invoke(8L, &anon_5uk);
		switch (num4)
		{
		case 0:
		case 1:
			return;
		}
		goto IL_02d0;
		IL_0216:
		if (num7 == 3)
		{
			goto IL_0225;
		}
		goto IL_02d0;
	}
}
