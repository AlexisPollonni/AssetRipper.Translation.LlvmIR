using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Getauxval
{
	public unsafe static readonly void* __pointer = (delegate*<long, long>)(&Invoke);

	[MangledName("getauxval")]
	[DemangledName("getauxval")]
	public unsafe static long Invoke([MangledName("id")] long Id)
	{
		long result = 0L;
		AuxvErrnoGuard auxvErrnoGuard = default(AuxvErrnoGuard);
		Anon_5uk363 anon_5uk = default(Anon_5uk363);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		AuxEntry auxEntry = default(AuxEntry);
		Llvm_lifetime_start_p0.Invoke(8L, &auxvErrnoGuard);
		unchecked
		{
			*(int*)(&auxvErrnoGuard) = -1431655766;
			((sbyte*)(&auxvErrnoGuard))[4] = -86;
			sbyte* ptr = (sbyte*)(&auxvErrnoGuard) + 5;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			AuxvErrnoGuard_Constructor.Invoke(&auxvErrnoGuard);
			Llvm_lifetime_start_p0.Invoke(8L, &anon_5uk);
			*(IntPtr*)(&anon_5uk) = unchecked((nint)(-6148914691236517206L));
			anon_5uk.field_0 = &auxvErrnoGuard;
			if (App.Pointer != null)
			{
				result = _0_Invoke_qwsr2x.Invoke(&anon_5uk, App.Pointer->Auxv_ptr, Id);
			}
			else
			{
				Callonce.Invoke(Getauxval_impl_unsigned_long_once_flag.Pointer, Initialize_auxv_once.__pointer);
				if (Auxv.Value == null)
				{
					Llvm_lifetime_start_p0.Invoke(4L, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
					*(int*)(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt) = -1431655766;
					AuxvFdGuard_Constructor.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
					if (AuxvFdGuard_valid.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt))
					{
						int num4;
						do
						{
							Llvm_lifetime_start_p0.Invoke(16L, &auxEntry);
							*(long*)(&auxEntry) = -6148914691236517206L;
							((long*)(&auxEntry))[1] = -6148914691236517206L;
							Struct_fiz2nb struct_fiz2nb = Read_entry.Invoke(AuxvFdGuard_get.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt));
							AuxEntry* num = &auxEntry;
							Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
							*(long*)num = struct_fiz2nb2.field_0;
							byte* num2 = (byte*)(&auxEntry) + 8u;
							Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
							*(long*)num2 = struct_fiz2nb3.field_1;
							int num3;
							if (auxEntry.Tv_sec == 0L)
							{
								num3 = 3;
							}
							else if (auxEntry.Tv_sec == Id)
							{
								result = auxEntry.Tv_nsec;
								num3 = 1;
							}
							else
							{
								num3 = 0;
							}
							Llvm_lifetime_end_p0.Invoke(16L, &auxEntry);
							num4 = num3;
						}
						while (num4 == 0);
						if (num4 != 3)
						{
							goto IL_0201;
						}
					}
					AuxvErrnoGuard_mark_failure.Invoke(&auxvErrnoGuard);
					result = 0L;
					goto IL_0201;
				}
				result = _0_Invoke_qwsr2x.Invoke(&anon_5uk, Auxv.Value, Id);
			}
			goto IL_021a;
		}
		IL_021a:
		Llvm_lifetime_end_p0.Invoke(8L, &anon_5uk);
		AuxvErrnoGuard_Destructor.Invoke(&auxvErrnoGuard);
		Llvm_lifetime_end_p0.Invoke(8L, &auxvErrnoGuard);
		return result;
		IL_0201:
		AuxvFdGuard_Destructor.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		Llvm_lifetime_end_p0.Invoke(4L, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		goto IL_021a;
	}
}
